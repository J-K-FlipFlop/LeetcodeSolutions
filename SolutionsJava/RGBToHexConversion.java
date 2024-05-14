public class RgbToHex {

    public static String rgb(int r, int g, int b) {
        if(r < 0) r = 0;
        if(r > 255) r = 255;
        if(g < 0) g = 0;
        if(g > 255) g = 255;
        if(b < 0) b = 0;
        if(b > 255) b = 255;

        String r1 = Integer.toHexString(r/16);
        String r2 = Integer.toHexString(r%16);
        String g1 = Integer.toHexString(g/16);
        String g2 = Integer.toHexString(g%16);
        String b1 = Integer.toHexString(b/16);
        String b2 = Integer.toHexString(b%16);

        return (r1 + r2 + g1 + g2 + b1 +b2).toUpperCase();
    }
}