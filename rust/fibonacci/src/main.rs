fn fib(n : u128) -> u128
{
    match n
    {
        0 => 0,
        1 => 1,
        _ => fib(n - 1) + fib(n - 2)
    }
}


fn main() 
{
    println!("value is {}", fib(8));
}
