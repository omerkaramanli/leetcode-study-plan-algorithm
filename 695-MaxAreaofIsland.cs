public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        var n = grid.Length;
        if (n == 0) return 0;
        var m = grid[0].Length;
        for (int i = 0; i < n; i++){
            for (int j = 0; j < m; j++)
                if (grid[i][j] == 1) {
                    var size = dfs(grid, i, j);
                    if(size>max) max = size;
                }
        }    
        return max;     
    }
    
    public int dfs(int[][] grid, int x, int y){
        if ((x >= 0) && (y >= 0) && (x < grid.Length) && (y < grid[0].Length) && (grid[x][y] == 1))
        {
            grid[x][y] = '0';
            return 1+dfs(grid, x-1, y) + dfs(grid, x, y-1) + dfs(grid, x+1, y) + dfs(grid, x, y+1);
        }
        else return 0;
    }
}