// 733. Flood Fill

namespace LeetCode.csharp_algorithms
{
    internal static class FloodFill
    {
        public static int[][] Fill(int[][] image, int sr, int sc, int color)
        {
            return RecursiveFloodFill(image, sr, sc, color, image[sr][sc]);

            int[][] RecursiveFloodFill(int[][] initImage, int pixel1, int pixel2, int resColor, int initColor)
            {
                if (pixel1 < 0 || pixel1 >= image.Length ||
                    pixel2 < 0 || pixel2 >= image[pixel1].Length ||
                    initImage[pixel1][pixel2] == resColor)
                    return initImage;

                if (initImage[pixel1][pixel2] == initColor)
                {
                    initImage[pixel1][pixel2] = resColor;
                    initImage = RecursiveFloodFill(initImage, pixel1 + 1, pixel2, resColor, initColor);
                    initImage = RecursiveFloodFill(initImage, pixel1 - 1, pixel2, resColor, initColor);
                    initImage = RecursiveFloodFill(initImage, pixel1, pixel2 + 1, resColor, initColor);
                    initImage = RecursiveFloodFill(initImage, pixel1, pixel2 - 1, resColor, initColor);
                }

                return initImage;
            }
        }
    }
}
