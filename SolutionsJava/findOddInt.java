import java.util.HashMap;
import java.util.Map;

public class FindOdd {
	public static int findIt(int[] a) {
  	    HashMap<Integer, Integer> myMap = new HashMap<>();

        for(int i = 0; i < a.length; i++){

            if (!myMap.containsKey(a[i])){
                myMap.put(a[i], 0);
            }

            myMap.put(a[i], myMap.get(a[i]) + 1);
        }


        for(Map.Entry<Integer, Integer> entry : myMap.entrySet()){
            if(entry.getValue() % 2 != 0){
                return entry.getKey();
            }
        }

        return 0;
  }
}