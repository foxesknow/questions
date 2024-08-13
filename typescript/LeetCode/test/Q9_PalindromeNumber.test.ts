function isPalindrome(x: number): boolean {
    if (x < 0) return false;

    let reversed : number = 0;
    let copy = x;

    while (copy != 0) {
        reversed = (reversed * 10) + (copy % 10);
        copy = Math.trunc(copy / 10);
    }

    return reversed == x;  
};

test("example 1", () => {
    expect(isPalindrome(121)).toBe(true);
});

test("example 2", () => {
    expect(isPalindrome(-121)).toBe(false);
});

test("example 3", () => {
    expect(isPalindrome(10)).toBe(false);
});

test("example 4", () => {
    expect(isPalindrome(7)).toBe(true);
});

test("example 5", () => {
    expect(isPalindrome(1234321)).toBe(true);
});