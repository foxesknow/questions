use function Facebook\FBExpect\expect;
use type Facebook\HackTest\{DataProvider, HackTest};

final class Q21_MergeTwoSortedListsTest extends HackTest {
  public function testExample1(): void {
    $list1 = ListNode::makeList(1, 2, 4);
    $list2 = ListNode::makeList(1, 3, 4);
    
    $merged = mergeTwoLists($list1, $list2);
    expect($merged)->toNotBeNull();

    $head = $merged as nonnull;

    expect($head->val)->toBeSame(1);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(1);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(2);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(3);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(4);
    expect(ListNode::requireNext(inout $head))->toNotBeNull() |> expect($$->val)->toBeSame(4);
    expect($head->next)->toBeNull();
  }

  public function testExample2(): void {
    $merged = mergeTwoLists(null, null);
    expect($merged)->toBeNull();
  }

  public function testExample3(): void {
    $merged = mergeTwoLists(null, new ListNode(0));
    expect($merged)->toNotBeNull();

    $head = $merged as nonnull;
    expect($head->val)->toBeSame(0);
    expect($head->next)->toBeNull();
  }
}