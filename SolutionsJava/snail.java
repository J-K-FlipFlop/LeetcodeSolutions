public class Snail {

    public static int[] snail(int[][] array) {
        int n = array.length;
        int m = array[0].length;
        int[] result = new int[n*m];
        int count = 0;

        if(m == 0){
            return result;
        }

        for(int i = 0; i < n; i++){
            for (int j = i; j < n-i; j++, count++){
                result[count] = array[i][j];
            }
            for (int j = 1 + i; j < n-i; j++, count++){
                result[count] = array[j][n-1-i];
            }
            for (int j = n - 1 - i; j > i; j--, count++){
                result[count] = array[n-i-1][j-1];
            }
            for (int j = n - 1 - i; j > i + 1; j--, count++){
                result[count] = array[j-1][i];
            }
        }

        return result;
   } 
}