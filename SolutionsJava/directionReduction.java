import java.util.List;
import java.util.Arrays;
import java.util.ArrayList;

public class DirReduction {
    public static String[] dirReduc(String[] arr) {
        List<String> myList = new ArrayList<>(Arrays.asList(arr));

        for (int i = 0; i < myList.size() - 1; i++){
            System.out.println(myList);
            switch(myList.get(i)){
                case "NORTH":
                    if( myList.get(i+1) == "SOUTH"){
                        myList.remove(i+1);
                        myList.remove(i);
                        i = -1;
                    }
                    break;
                case "SOUTH" :
                    if( myList.get(i+1) == "NORTH"){
                        myList.remove(i+1);
                        myList.remove(i);
                        i = -1;
                    }
                    break;
                case "WEST" :
                    if( myList.get(i+1) == "EAST"){
                        myList.remove(i+1);
                        myList.remove(i);
                        i = -1;
                    }
                    break;
                case "EAST" :
                    if( myList.get(i+1) == "WEST"){
                        myList.remove(i+1);
                        myList.remove(i);
                        i = -1;
                    }
                    break;
            }
        }

        String[] result = new String[myList.size()];

        for(int i = 0; i < myList.size(); i++){
            result[i] = myList.get(i).toString();
        }

        return result;
    }
}