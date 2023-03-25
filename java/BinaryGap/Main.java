// https://app.codility.com/programmers/lessons/1-iterations/binary_gap/

public class Main
{
    public static void main(String[] args)
    {
        var binaryGap = new Main();

        System.out.println(binaryGap.solution(9));
        System.out.println(binaryGap.solution(529));
        System.out.println(binaryGap.solution(20));
        System.out.println(binaryGap.solution(104));

        System.out.println("done");
    }

    public int solution(int N)
    {
        var longest = 0;
        var counting = false;
        var currentRun = 0;

        while(N != 0)
        {
            var nextBit = N & 1;

            if(nextBit == 1)
            {
                counting = true;

                if(currentRun > longest)
                {
                    longest = currentRun;
                }

                currentRun = 0;
            }            
            else
            {
                if(counting) currentRun++;
            }

            N >>= 1;
        }

        return longest;
    }
}