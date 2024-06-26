use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q50_PowTest extends HackTest {
  public function generateTestData(): vec<(float, int, float)> {
    return vec [
      tuple(2.0, 10, 1024.0),
      tuple(2.1, 3, 9.2610),
      tuple(2.0, -2, 0.25),
    ];
  }

  <<DataProvider('generateTestData')>>
  public function testExamples(float $x, int $n, float $expected): void {
    $s = new LeetCode\Q50\Solution();
    $result = $s->myPow($x, $n);
    expect($result)->toAlmostEqual($expected);
  }
}