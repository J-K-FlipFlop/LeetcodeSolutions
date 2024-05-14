public class Max {
    public static int sequence(int[] arr) {
          int maxSum = 0;
          int sum = 0;
  
          for(int i = 0; i < arr.length; i++){
              sum = arr[i];
              if(sum > maxSum){
                  maxSum = sum;
              }
              for(int j = i + 1; j < arr.length; j++){
                  sum = sum + arr[j];
                  if(sum > maxSum){
                      maxSum = sum;
                  }
              }
          }
  
          return maxSum;
    }
  }