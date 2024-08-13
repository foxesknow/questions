function twoSum(nums: number[], target: number): number[] {
    let cache = new Map<number, number>();

    for (var i = 0; i < nums.length; i++) {
        let diff = target - nums[i];
        
        let index = cache.get(diff);
        if(index != undefined) {
            return [i, index];
        }

        cache.set(nums[i], i);
    }

    return [];
}

test("example 1", () => {
    let result = twoSum([2,7,11,15], 9);
    expect(result).toContain(0);
    expect(result).toContain(1);
});

test("example 2", () => {
    let result = twoSum([3,2,4], 6);
    expect(result).toContain(1);
    expect(result).toContain(2);
});

test("example 3", () => {
    let result = twoSum([3,3], 6);
    expect(result).toContain(0);
    expect(result).toContain(0);
});