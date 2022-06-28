public class Solution {
    public int OrangesRotting(int[][] grid) {
        if(grid.Length == 0) return 0;
        int sr = grid.Length, sc = grid[0].Length;
        Queue<int[]> queue = new Queue<int[]>();
        int fresh = 0;
        
        for(int i = 0; i<sr; i++){
            for(int j = 0; j<sc; j++){
                if(grid[i][j] == 2){
                    queue.Enqueue(new int[]{i,j});
                }
                if(grid[i][j] == 1){
                    fresh++;            
                }
            }
        }
        
        if(fresh == 0) return 0;
        if(queue.Count == 0) return -1;
        
        int count = 0;
        
        while(queue.Count != 0){
            count++;
            int size = queue.Count;
            for(int i = 0; i<size; i++){
                var item = queue.Dequeue();
                if(item[0]-1>=0 && grid[item[0]-1][item[1]] == 1) {
                    grid[item[0]-1][item[1]] = 2;
                    fresh--;                    
                    int[] rotten = {item[0]-1,item[1]};
                    if(!queue.Contains(rotten)) queue.Enqueue(rotten);
                }
                if(item[1]-1>=0 && grid[item[0]][item[1]-1] == 1) {
                    grid[item[0]][item[1]-1] = 2;
                    fresh--;
                    int[] rotten = {item[0],item[1]-1};                    
                    if(!queue.Contains(rotten)) queue.Enqueue(rotten);
                }
                if(item[0]+1<sr && grid[item[0]+1][item[1]] == 1) {
                    grid[item[0]+1][item[1]] = 2;
                    fresh--;
                    int[] rotten = {item[0]+1,item[1]}; 
                    if(!queue.Contains(rotten)) queue.Enqueue(rotten);
                }
                if(item[1]+1<sc && grid[item[0]][item[1]+1] == 1) {
                    grid[item[0]][item[1]+1] = 2;
                    fresh--;
                    int[] rotten = {item[0],item[1]+1}; 
                    if(!queue.Contains(rotten)) queue.Enqueue(rotten);
                }
            }
        }
        return fresh == 0 ? count-1 : -1;
        
        
    }    
}