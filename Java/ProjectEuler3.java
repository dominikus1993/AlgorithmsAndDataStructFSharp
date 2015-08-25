import java.lang.reflect.Array;
import java.util.*;
import java.util.stream.IntStream;


class Problem3 {
    public static List<Long> findFactor(long number){
        List<Long> intList = new ArrayList<>();
        for (long i = 2; i < (long)Math.sqrt(number); i++) {
            if (number % i == 0){
                System.out.println(i);
                intList.add(i);
            }
        }
        return intList;
    }

    public static boolean isPrime(long number){
        return number == 1 ? false :IntStream.range(2, (int) Math.sqrt(number) + 1).asLongStream().filter(x -> number % x == 0).toArray().length == 0;
    }

}

public class Main {

    public static void main(String[] Args){
        long num = 600851475143L;
        long a = Problem3.findFactor(num).stream().filter(x -> num % x == 0).filter(Problem3::isPrime).max((o1, o2) -> o1 > o2 ? 1 : o2 > o1?-1 :0).get();
        System.out.println(a);

    }

}
