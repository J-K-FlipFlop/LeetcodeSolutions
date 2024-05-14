public class TenMinWalk {
    public static boolean isValid(char[] walk) {
      
          int longitude = 0;
          int latitude = 0;
  
          for(int i = 0; i < walk.length; i++){
              char c = walk[i];
  
              switch (c){
                  case 'n':
                      longitude = longitude + 1;
                      break;
                  case 's':
                      longitude = longitude - 1;
                      break;
                  case 'w':
                      latitude = latitude + 1;
                      break;
                  case 'e':
                      latitude = latitude - 1;
                      break;
              }
          }
          
          if(latitude == 0 && longitude == 0 && walk.length == 10){
              return true;
          }
          else{
              return false;
          }
    }
  }