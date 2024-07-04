use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

class Q141_LinkedListCycleTest extends HackTest {
  public function testExample1(): void {
    $s = new LeetCode\Q141\Solution();

    $n1 = new ListNode(3);
    $n2 = new ListNode(2);
    $n3 = new ListNode(0);
    $n4 = new ListNode(-4);

    $n1->next = $n2;
    $n2->next = $n3;
    $n3->next = $n4;
    $n4->next = $n2;

    $head = $n1;
    expect($s->hasCycle($head))->toBeTrue();
  }

  public function testExample2(): void {
    $s = new LeetCode\Q141\Solution();

    $n1 = new ListNode(1);
    $n2 = new ListNode(2);

    $n1->next = $n2;
    $n2->next = $n1;

    $head = $n1;
    expect($s->hasCycle($head))->toBeTrue();
  }

  public function testExample3(): void {
    $s = new LeetCode\Q141\Solution();

    $n1 = new ListNode(1);
    $head = $n1;
    expect($s->hasCycle($head))->toBeFalse();
  }
}