use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q26_RemoveDuplicatesFromSortedArrayTest extends HackTest {
  public function testExample1(): void {
    $solution = new LeetCode\Q26\Solution();
    $nums = vec[1, 1, 2];
    $k = $solution->removeDuplicates(inout $nums);
    expect($k)->toBeSame(2);
    expect($nums[0])->toEqual(1);
    expect($nums[1])->toEqual(2);
  }

  public function testExample2(): void {
    $solution = new LeetCode\Q26\Solution();
    $nums = vec[0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
    $k = $solution->removeDuplicates(inout $nums);
    expect($k)->toBeSame(5);
    expect($nums[0])->toEqual(0);
    expect($nums[1])->toEqual(1);
    expect($nums[2])->toEqual(2);
    expect($nums[3])->toEqual(3);
    expect($nums[4])->toEqual(4);
  }
}