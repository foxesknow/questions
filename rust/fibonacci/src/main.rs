use std::{collections::HashMap};

// The canonical fibanacci implementation
fn fib(n : u32) -> u128
{
    match n
    {
        0 => 0,
        1 => 1,
        _ => fib(n - 1) + fib(n - 2)
    }
}

// Working out the fibanacci number by starting from 0 and moving forward
fn fib_seq(n : u32) -> u128
{
    let mut current : u128 = 0;
    let mut next : u128 = 1;
    let mut count: u32 = n;

    while count != 0
    {
        let (new_current, new_next) = (next, next + current);
        current = new_current;
        next = new_next;
        count -= 1;
    }

    current
}

// Using memoization to work out the value
fn fib_mem(n : u32) -> u128
{
    let mut cache: HashMap<u32, u128> = HashMap::new();
    cache.insert(0, 0);
    cache.insert(1, 1);

    return execute(&mut cache, n);

    fn execute(cache: &mut HashMap<u32, u128>, n: u32) -> u128
    {
        if let Some(&number) = cache.get(&n) 
        {
            number
        }
        else
        {
            let x = execute(cache, n - 1) + execute(cache, n - 2);
            cache.insert(n, x);
            x
        }
    }
}

#[cfg(test)]
mod tests
{
    use super::*;

    #[test]
    fn test_fib()
    {
        assert_eq!(fib(0), 0);
        assert_eq!(fib(1), 1);
        assert_eq!(fib(1), 1);
        assert_eq!(fib(5), 5);
        assert_eq!(fib(10), 55);
    }

    #[test]
    fn test_fib_seq()
    {
        assert_eq!(fib_seq(0), 0);
        assert_eq!(fib_seq(1), 1);
        assert_eq!(fib_seq(1), 1);
        assert_eq!(fib_seq(5), 5);
        assert_eq!(fib_seq(10), 55);
    }

    #[test]
    fn test_fib_mem()
    {
        assert_eq!(fib_mem(0), 0);
        assert_eq!(fib_mem(1), 1);
        assert_eq!(fib_mem(1), 1);
        assert_eq!(fib_mem(5), 5);
        assert_eq!(fib_mem(10), 55);
    }
}

fn main() 
{
    println!("fib is {}", fib(40));
    println!("fib_mem is {}", fib_mem(40));
    println!("fib_seq is {}", fib_seq(40));
}
