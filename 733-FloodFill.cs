public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int oldColor = image[sr][sc];
        if(oldColor!=newColor) flood(image, sr, sc, newColor, oldColor);
        return image;
    }
    
    public void flood(int[][] image, int sr, int sc, int newColor, int oldColor){
        if(image[sr][sc] == oldColor){
            image[sr][sc] = newColor;
            if(sr-1>=0) flood(image, sr-1, sc, newColor, oldColor);
            if(sc-1>=0) flood(image, sr, sc-1, newColor, oldColor);
            if(sr+1<image.Length) flood(image, sr+1, sc, newColor, oldColor);
            if(sc+1<image[0].Length) flood(image, sr, sc+1, newColor, oldColor);
        }
    }
}