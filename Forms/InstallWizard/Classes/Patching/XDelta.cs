using DarkUI.Forms;
using ShrineFox.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Adapted from zarroboogs' ppp repository
namespace PersonaPatchGen
{
    public partial class WizardForm
    {
        public static void ApplyPersonaPS4Patches(string[] args)
        {
            string pathIn = args[0];
            string pathOut = args.Length > 1 && !args[1].StartsWith("--") ? args[1] : $"{pathIn}--patched.bin";

            List<string> PPP_PatchIds = new();
            int PPP_PatchIndex = Array.IndexOf(args, "--patch");
            if (PPP_PatchIndex != -1)
            {
                PPP_PatchIds = args.Skip(PPP_PatchIndex + 1).ToList();
            }

            if (!DetectFormat(pathIn))
            {
                Output.Log("Input not in ELF format");
                return;
            }

            var game = DetectGame(pathIn);
            if (game == null)
            {
                Output.Log("Unsupported game or game version");
                return;
            }

            Output.Log($"Found {game.Name} {game.Title} {game.Version}");

            var gamePPP_Patches = XdeltaConf.PPP_Patches
                .Where(p => p.Games.ContainsKey(game.Title) && p.Games[game.Title].Contains(game.Version))
                .ToDictionary(p => p.Id);

            if (PPP_PatchIds.Count == 0)
            {
                Output.Log("Available Patches:");
                int w = gamePPP_Patches.Keys.Max(k => k.Length);
                foreach (var PPP_Patch in gamePPP_Patches.Values)
                {
                    if (PPP_Patch.Display)
                        Output.Log($"  {PPP_Patch.Id.PadRight(w + 2)} {PPP_Patch.Name}");
                }
                return;
            }

            if (Path.GetFullPath(pathIn) == Path.GetFullPath(pathOut))
            {
                Output.Log("Output path can't be identical to input path");
                return;
            }

            List<string> apply = new();
            List<string> applyPids = new();

            foreach (var pid in PPP_PatchIds)
            {
                if (!gamePPP_Patches.ContainsKey(pid))
                {
                    Output.Log($"Unknown Patch id {pid}, skipping...");
                    continue;
                }

                string PPP_PatchPath = Path.Combine("xdelta", gamePPP_Patches[pid].Path);
                if (!File.Exists(PPP_PatchPath))
                {
                    Output.Log($"Patch file for id {pid} not found, skipping...");
                    continue;
                }

                apply.Add(Path.GetFullPath(PPP_PatchPath).Replace('\\', '/'));
                applyPids.Add(pid);
            }

            if (apply.Count == 0)
            {
                Output.Log("No Patches to apply");
                return;
            }

            for (int i = 0; i < apply.Count - 1; i++)
                apply[i] = $"-m{apply[i]}";

            Output.Log("Applying Patches...");
            ApplyPPP_Patches(pathIn, pathOut, apply);
            Output.Log($"Applied {string.Join(" ", applyPids)}");
        }


        static byte[] ReadAt(FileStream stream, long offset, int count)
        {
            byte[] buffer = new byte[count];
            stream.Seek(offset, SeekOrigin.Begin);
            stream.Read(buffer, 0, count);
            return buffer;
        }

        static bool DetectFormat(string path)
        {
            using var stream = File.OpenRead(path);
            var magic = new byte[4];
            stream.Read(magic, 0, 4);
            return magic.SequenceEqual(new byte[] { 0x7F, (byte)'E', (byte)'L', (byte)'F' });
        }

        static PPP_Game DetectGame(string path)
        {
            using var stream = File.OpenRead(path);
            foreach (var game in XdeltaConf.Games)
            {
                bool ok = true;
                foreach (var check in game.Checks)
                {
                    var expected = check.Value;
                    var actual = ReadAt(stream, check.Offset, expected.Length);
                    if (!actual.SequenceEqual(Encoding.ASCII.GetBytes(check.Value)))
                    {
                        ok = false;
                        break;
                    }
                }
                if (ok)
                    return game;
            }
            return null;
        }

        static void ApplyPPP_Patches(string pathIn, string pathOut, List<string> apply)
        {
            string mergeArgs = $"merge {string.Join(" ", apply)} ./tmp.xdelta";
            RunXdelta(mergeArgs);

            string decodeArgs = $"-d -s \"{pathIn}\" ./tmp.xdelta \"{pathOut}\"";
            RunXdelta(decodeArgs);
        }

        static void RunXdelta(string args)
        {
            ShrineFox.IO.Exe.Run(Path.GetFullPath(".//Dependencies//xdelta.exe"), args, redirectStdOut: true, unicodeEncoding: false);
        }

        public class PPP_Game
        {
            public string Name { get; set; }
            public string Title { get; set; }
            public string Version { get; set; }
            public List<Check> Checks { get; set; }
        }

        public class Check
        {
            public long Offset { get; set; }
            public string Value { get; set; } // This is a string like "CUSA05877" instead of raw bytes for simplicity

            public byte[] GetBytes() => System.Text.Encoding.ASCII.GetBytes(Value);
        }

        public class PPP_PPP_Patch
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Path { get; set; }
            public bool Display { get; set; } = true;
            public Dictionary<string, List<string>> Games { get; set; }
        }


        public static class XdeltaConf
        {
            public static readonly List<PPP_Game> Games = new()
            {
                new PPP_Game {
                    Name = "Persona 5 (PS4) US v1.00",
                    Title = "CUSA05877",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x10CAE67, Value = "CUSA05877" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 5 (PS4) EU v1.00",
                    Title = "CUSA06638",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x10CAE97, Value = "CUSA06638" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 5 Royal US v1.02",
                    Title = "CUSA17416",
                    Version = "0102",
                    Checks = new List<Check> {
                        new Check { Offset = 0x18110E7, Value = "CUSA17416" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 5 Royal EU v1.02",
                    Title = "CUSA17419",
                    Version = "0102",
                    Checks = new List<Check> {
                        new Check { Offset = 0x18110E7, Value = "CUSA17419" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 5: Dancing in Starlight (PS4) US v1.00",
                    Title = "CUSA12380",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x4241E0, Value = "CUSA12380" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 3: Dancing in Moonlight (PS4) US v1.00",
                    Title = "CUSA12636",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x4211E0, Value = "CUSA12636" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 4: Dancing All Night (PS4) EU v1.00",
                    Title = "CUSA12811",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x3BEBE0, Value = "CUSA12811" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 5: Dancing in Starlight (PSV) US v1.00",
                    Title = "PCSE01275",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x2F6107, Value = "PCSE01275" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 3: Dancing in Moonlight (PSV) US v1.00",
                    Title = "PCSE01274",
                    Version = "0100",
                    Checks = new List<Check> {
                        new Check { Offset = 0x2F2503, Value = "PCSE01274" }
                    }
                },
                new PPP_Game {
                    Name = "Persona 4: Dancing All Night (PSV) US v1.01",
                    Title = "PCSE00764",
                    Version = "0101",
                    Checks = new List<Check> {
                        new Check { Offset = 0x256F07, Value = "PCSE00764" }
                    }
                }
            };

            public class PPP_Patch
            {
                public string Path { get; set; }
                public string Id { get; set; }
                public string Name { get; set; }
                public Dictionary<string, string> Games { get; set; }
                public bool Display { get; set; } = true; // default true unless specified false
            }

            public static readonly List<PPP_Patch> PPP_Patches = new List<PPP_Patch>
            {
                new PPP_Patch {
                    Path = "CUSA05877_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/mod_support.xdelta",
                    Id = "mod_support",
                    Name = "Mod Support (PKG)",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/mod_support2.xdelta",
                    Id = "mod_support2",
                    Name = "Mod Support (FTP)",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/share_button.xdelta",
                    Id = "share_button",
                    Name = "Enable Share Button",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/square.xdelta",
                    Id = "square",
                    Name = "Global Square Menu",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/env.xdelta",
                    Id = "env",
                    Name = "ENV Test",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "CUSA05877_0100/zzz.xdelta",
                    Id = "zzz",
                    Name = "Random Tests",
                    Games = new Dictionary<string, string> { { "CUSA05877", "0100" } },
                    Display = false
                },

                new PPP_Patch {
                    Path = "CUSA06638_0100/all_dlc.xdelta",
                    Id = "all_dlc",
                    Name = "Content Enabler",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/mod_support.xdelta",
                    Id = "mod_support",
                    Name = "Mod Support (PKG)",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/mod_support2.xdelta",
                    Id = "mod_support2",
                    Name = "Mod Support (FTP)",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/share_button.xdelta",
                    Id = "share_button",
                    Name = "Enable Share Button",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/square.xdelta",
                    Id = "square",
                    Name = "Global Square Menu",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/env.xdelta",
                    Id = "env",
                    Name = "ENV Test",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "CUSA06638_0100/zzz.xdelta",
                    Id = "zzz",
                    Name = "Random Tests",
                    Games = new Dictionary<string, string> { { "CUSA06638", "0100" } },
                    Display = false
                },

                new PPP_Patch {
                    Path = "CUSA17416_0102/0505.xdelta",
                    Id = "0505",
                    Name = "PS4 FW 5.05 Backport",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/all_dlc.xdelta",
                    Id = "all_dlc",
                    Name = "Content Enabler",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/dlc_msg.xdelta",
                    Id = "dlc_msg",
                    Name = "Skip DLC Unlock Messages",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/p5_save.xdelta",
                    Id = "p5_save",
                    Name = "P5 Save Bonus Enabler",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/share_button.xdelta",
                    Id = "share_button",
                    Name = "Enable Share Button",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/square.xdelta",
                    Id = "square",
                    Name = "Global Square Menu",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/bgm_ord.xdelta",
                    Id = "bgm_ord",
                    Name = "Sequential Battle BGM",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/bgm_rnd.xdelta",
                    Id = "bgm_rnd",
                    Name = "Randomized Battle BGM",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } }
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/env.xdelta",
                    Id = "env",
                    Name = "ENV Test",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "CUSA17416_0102/zzz.xdelta",
                    Id = "zzz",
                    Name = "Random Tests",
                    Games = new Dictionary<string, string> { { "CUSA17416", "0102" }, { "CUSA17419", "0102" } },
                    Display = false
                },

                new PPP_Patch {
                    Path = "CUSA12380_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA12380", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12380_0100/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "CUSA12380", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12380_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA12380", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12380_0100/overlay.xdelta",
                    Id = "overlay",
                    Name = "Disable Screenshot Overlay",
                    Games = new Dictionary<string, string> { { "CUSA12380", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12380_0100/psvc.xdelta",
                    Id = "psvc",
                    Name = "PSV Content Compat.",
                    Games = new Dictionary<string, string> { { "CUSA12380", "0100" } },
                    Display = false
                },

                new PPP_Patch {
                    Path = "CUSA12636_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA12636", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12636_0100/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "CUSA12636", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12636_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA12636", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12636_0100/overlay.xdelta",
                    Id = "overlay",
                    Name = "Disable Screenshot Overlay",
                    Games = new Dictionary<string, string> { { "CUSA12636", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12636_0100/psvc.xdelta",
                    Id = "psvc",
                    Name = "PSV Content Compat.",
                    Games = new Dictionary<string, string> { { "CUSA12636", "0100" } },
                    Display = false
                },

                new PPP_Patch {
                    Path = "CUSA12811_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "CUSA12811", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12811_0100/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "CUSA12811", "0100" } }
                },
                new PPP_Patch {
                    Path = "CUSA12811_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "CUSA12811", "0100" } }
                },

                new PPP_Patch {
                    Path = "PCSE01275_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "PCSE01275", "0100" } }
                },
                new PPP_Patch {
                    Path = "PCSE01275_0100/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "PCSE01275", "0100" } }
                },
                new PPP_Patch {
                    Path = "PCSE01275_0100/auto.xdelta",
                    Id = "auto",
                    Name = "Auto Play",
                    Games = new Dictionary<string, string> { { "PCSE01275", "0100" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "PCSE01275_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "PCSE01275", "0100" } }
                },

                new PPP_Patch {
                    Path = "PCSE01274_0100/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "PCSE01274", "0100" } }
                },
                new PPP_Patch {
                    Path = "PCSE01274_0100/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "PCSE01274", "0100" } }
                },
                new PPP_Patch {
                    Path = "PCSE01274_0100/auto.xdelta",
                    Id = "auto",
                    Name = "Auto Play",
                    Games = new Dictionary<string, string> { { "PCSE01274", "0100" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "PCSE01274_0100/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "PCSE01274", "0100" } }
                },

                new PPP_Patch {
                    Path = "PCSE00764_0101/intro_skip.xdelta",
                    Id = "intro_skip",
                    Name = "Intro Skip",
                    Games = new Dictionary<string, string> { { "PCSE00764", "0101" } }
                },
                new PPP_Patch {
                    Path = "PCSE00764_0101/mod.xdelta",
                    Id = "mod",
                    Name = "Mod Support",
                    Games = new Dictionary<string, string> { { "PCSE00764", "0101" } }
                },
                new PPP_Patch {
                    Path = "PCSE00764_0101/auto.xdelta",
                    Id = "auto",
                    Name = "Auto Play",
                    Games = new Dictionary<string, string> { { "PCSE00764", "0101" } },
                    Display = false
                },
                new PPP_Patch {
                    Path = "PCSE00764_0101/no_trp.xdelta",
                    Id = "no_trp",
                    Name = "Disable Trophies",
                    Games = new Dictionary<string, string> { { "PCSE00764", "0101" } }
                },
            };
        }

    }
}