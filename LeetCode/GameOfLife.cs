using System.Text;

namespace LeetCode
{
    internal class GameOfLife
    {
        public static string GameofLifeStrings(string str)
        {
            var initGeneration = new List<List<bool>>();
            var inner = new List<bool>();

            // Parse the input string 
            foreach (char cell in str)
            {
                if (cell == '0')
                {
                    inner.Add(false);
                }
                else if (cell == '1')
                {
                    inner.Add(true);
                }
                else if (cell == '_')
                {
                    initGeneration.Add(inner);
                    inner = new List<bool>();
                }
                else
                {
                    throw new ArgumentException("Unexpected character value");
                }
            }
            initGeneration.Add(inner);

            // Validate that all inner lists have the same length
            if (initGeneration.Count > 1)
            {
                int expectedLength = initGeneration[0].Count;
                foreach (var row in initGeneration)
                {
                    if (row.Count != expectedLength)
                    {
                        throw new ArgumentException("All rows must have the same number of columns.");
                    }
                }
            }

            // Build the result state for each cell
            var result = new StringBuilder();
            // Iterate over each cell
            for (var x = 0; x < initGeneration.Count; x++)
            {
                for (var y = 0; y < initGeneration[x].Count; y++)
                {
                    // Iterate over each cell neighbour
                    var liveNeighbours = 0;
                    for (var dx = -1; dx <= 1; dx++)
                    {
                        for (var dy = -1; dy <= 1; dy++)
                        {
                            if (dx == 0 && dy == 0) continue;
                            var nx = x + dx;
                            var ny = y + dy;

                            // Perform boudns checking
                            if (nx >= 0 && nx < initGeneration.Count && ny >= 0 && ny < initGeneration[x].Count && initGeneration[nx][ny])
                            {
                                liveNeighbours++;
                            }
                        }
                    }

                    // Push the resulting state according to the game rules
                    if (initGeneration[x][y])
                    {
                        if (liveNeighbours < 2 || liveNeighbours > 3) result.Append("0");
                        else result.Append("1");
                    }
                    else
                    {
                        if (liveNeighbours == 3) result.Append("1");
                        else result.Append("0");
                    }
                }

                if (x < initGeneration.Count - 1)
                {
                    result.Append("_");
                }
            }

            return result.ToString();
        }
    }
}
