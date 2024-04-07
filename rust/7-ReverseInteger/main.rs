pub fn reverse(x: i32) -> i32 {
    let max_int : i32 = 2147483647;
    let is_negative = (x < 0);
    let mut value = 0;

    let mut x = x;
    while x != 0 {
        let next_digit = (x % 10).abs();

        if value != 0 && ((max_int - next_digit) / value) < 10 {
            return 0;
        }

        value = (value * 10) + next_digit;
        x /= 10;
    }

    if is_negative {
        value *= -1;
    }

    value
}

fn main() 
{
    println!("{:?}",reverse(103));
    println!("{:?}",reverse(-987));
}