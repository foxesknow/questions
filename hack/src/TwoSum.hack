use namespace HH\Lib\Vec;
use namespace HH\Lib\C;

function two_sum(vec<int> $numbers, int $target): vec<int> {
    $cache = dict[];

    foreach ($numbers as $i => $value) {
        $existing = idx($cache, $target - $value);
        if ($existing != null) {            
            return vec[$existing, $i];
        } else {
            $cache[$value] = $i;
        }
    }

    throw new Exception();
}