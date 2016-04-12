namespace HarryPotter.Models
{
    using System.Collections.Generic;

    internal static class Tiles
    {
        private static readonly Dictionary<int, string> TileNumToPathMap = new Dictionary<int, string>
        {
            [0] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._0,
            [1] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._1,
            [10] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._10,
            [2] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._2,
            [3] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._3,
            [4] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._4,
            [5] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._5,
            [6] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._6,
            [7] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._7,
            [8] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._8,
            [9] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._9,
            [11] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._11,
            [12] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._12,
            [13] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._13,
            [14] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._14,
            [15] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._15,
            [16] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._16,
            [17] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._17,
            [18] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._18,
            [19] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._19,
            [20] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._20,
            [21] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._21,
            [22] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._22,
            [23] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._23,
            [24] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._24,
            [25] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._25,
            [26] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._26,
            [27] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._27,
            [28] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._28,
            [29] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._29,
            [30] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._30,
            [31] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._31,
            [32] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._32,
            [33] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._33,
            [34] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._34,
            [35] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._35,
            [36] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._36,
            [37] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._37,
            [38] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._38,
            [39] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._39,
            [40] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._40,
            [41] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._41,
            [42] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._42,
            [43] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._43,
            [44] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._44,
            [45] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._45,
            [46] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._46,
            [47] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._47,
            [48] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._48,
            [49] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._49,
            [50] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._50,
            [51] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._51,
            [52] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._52,
            [53] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._53,
            [54] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._54,
            [55] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._55,
            [56] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._56,
            [57] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._57,
            [58] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._58,
            [59] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._59,
            [60] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._60,
            [100] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._100,
            [101] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._101,
            [102] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._102,
            [103] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._103,
            [104] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._104,
            [105] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._105,
            [106] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._106,
            [107] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._107,
            [108] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._108,
            [109] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._109,
            [110] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._110,
            [111] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._111,
            [112] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._112,
            [113] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._113,
            [61] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._61,
            [62] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._62,
            [63] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._63,
            [64] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._64,
            [65] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._65,
            [66] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._66,
            [67] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._67,
            [68] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._68,
            [69] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._69,
            [70] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._70,
            [71] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._71,
            [72] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._72,
            [73] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._73,
            [74] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._74,
            [75] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._75,
            [76] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._76,
            [77] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._77,
            [78] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._78,
            [79] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._79,
            [80] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._80,
            [81] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._81,
            [82] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._82,
            [83] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._83,
            [84] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._84,
            [85] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._85,
            [86] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._86,
            [87] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._87,
            [88] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._88,
            [89] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._89,
            [90] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._90,
            [91] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._91,
            [92] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._92,
            [93] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._93,
            [94] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._94,
            [95] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._95,
            [96] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._96,
            [97] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._97,
            [98] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._98,
            [99] =
                WaveContent.Assets.Sprites.GroundUnitBoard_spritesheet_TextureName._99
        };

        public static string GetPath(int tileNum)
        {
            return TileNumToPathMap[tileNum];
        }
    }
}
