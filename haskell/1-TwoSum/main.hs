import Data.Map as Map
find :: Int -> Int -> [Int] -> Map Int Int -> [Int]
find _ _ [] _ = [-1, -1]
find target index (number:rest) map=
    case Map.lookup (target - number) map of
        Just value -> [index, value]
        _ -> find target (index + 1) rest $ Map.insert number index map


twoSum :: [Int] -> Int -> [Int]
twoSum nums target =
    find target 0 nums Map.empty

main = do
    print (twoSum [2, 7, 11, 15] 9)
    print (twoSum [3, 2, 4] 6)
    print (twoSum [3, 3] 6)
    print (twoSum [1,3,7,9,21,15] 24)