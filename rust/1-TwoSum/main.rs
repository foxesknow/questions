use std::{collections::HashMap};

pub fn two_sum(nums: Vec<i32>, target: i32) -> Vec<i32> 
{
    let mut indexes: HashMap<i32, i32> = HashMap::new();

    for(index, value) in nums.iter().enumerate()
    {
        if let Some(x) = indexes.get(&(target - *value))
        {
            return vec![index as i32, *x]
        }
        else
        {
            indexes.insert(*value, index as i32);
        }
    }

    return Vec::new();
}

fn main() 
{
    println!("{:?}", two_sum(vec![2,7,11,15], 9));
    println!("{:?}", two_sum(vec![3,2,4], 6));
    println!("{:?}", two_sum(vec![3,3], 6));
}