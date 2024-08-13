use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

final class Q24_SwapNodePairsTest extends HackTest {
  public function testExample1(): void {
    $list = ListNode::makeList(1, 2, 3, 4);
    $reversed = swapPairs($list);

    $head = expect($reversed)->toNotBeNull();
    expect($head->val)->toBeSame(2);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(1);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(4);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(3);
    expect($head->next)->toBeNull();
  }

  public function testExample2(): void {
    $reversed = swapPairs(null);

    expect($reversed)->toBeNull();
  }

  public function testExample3(): void {
    $list = ListNode::makeList(1);
    $reversed = swapPairs($list);

    $head = expect($reversed)->toNotBeNull();
    expect($head->val)->toBeSame(1);
    expect($head->next)->toBeNull();
  }
}