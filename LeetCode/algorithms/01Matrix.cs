// 542. 01 Matrix

namespace LeetCode.algorithms
{
    internal static class _01Matrix
    {
        public static int[][] UpdateMatrix(int[][] mat)
        {
            var queue = new Queue<(int, int)>();
            var max_value = mat.Length * mat[0].Length;

            for (int dy = 0; dy < mat.Length; dy++)
            {
                for (int dx = 0; dx < mat[dy].Length; dx++)
                {
                    if (mat[dy][dx] == 0)
                    {
                        queue.Enqueue((dy, dx));
                    }
                    else
                    {
                        mat[dy][dx] = max_value;
                    }
                }
            }

            var directions = new (int, int)[] {(-1, 0), (1, 0), (0, -1), (0, 1) };
            while (queue.Count != 0)
            {
                var (y, x) = queue.Dequeue();
                foreach (var dir in directions)
                {
                    var ny = y + dir.Item1;
                    var nx = x + dir.Item2;
                    if (ny >= 0 && ny < mat.Length && nx >= 0 && nx < mat[0].Length)
                    {
                        var value = mat[y][x] + 1;
                        if (value < mat[ny][nx])
                        {
                            mat[ny][nx] = value;
                            queue.Enqueue((ny, nx));
                        }
                    }
                }
            }

            return mat;
        }
    }
}
