import java.util.HashMap;

public class PangramChecker {
  public boolean check(String sentence){
    
        HashMap<Character, Integer> myMap = new HashMap<>();
        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".toCharArray();
        String str = sentence.toLowerCase();

        for(int i = 0; i < str.length(); i++){
            char c = str.charAt(i);
            myMap.put(c,1);
        }

        for(int i = 0; i < 26; i++){
            if(!myMap.containsKey(alphabet[i])){
                return false;
            }
        }

        return true;
  }
}