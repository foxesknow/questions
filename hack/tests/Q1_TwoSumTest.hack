use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

final class Q1_TwoSumTest extends HackTest {
    public function testExample1(): void {
        $nums = vec[2, 7, 11, 15];
        $result = two_sum($nums, 9);
        echo $result[0];
        expect($result)->toContain(0);
        expect($result)->toContain(1);
    }

    public function testExample2(): void {
        $nums = vec[3, 2, 4];
        $result = two_sum($nums, 6);
        echo $result[0];
        expect($result)->toContain(1);
        expect($result)->toContain(2);
    }

    public function testExample3(): void {
        $nums = vec[3, 3];
        $result = two_sum($nums, 6);
        echo $result[0];
        expect($result)->toContain(1);
        expect($result)->toContain(1);
    }
}