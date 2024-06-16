// LeetCode Question 13
use namespace HH\Lib\Str;

function roman_to_int(string $s): int {
    $value = 0;
    $previous = "";

    for($i = 0; $i < Str\length($s); $i++) {
        $c = $s[$i];
        
        switch ($c) {
            case "I":
                $value += 1;
                break;

            case "V":
                $value += ($previous === "I" ? 3 : 5);
                break;

            case "X":
                $value += ($previous === "I" ? 8 : 10);
                break;

            case "L":
                $value += ($previous === "X" ? 30 : 50);
                break;

            case "C":
                $value += ($previous === "X" ? 80 : 100);
                break;

            case "D":
                $value += ($previous === "C" ? 300 : 500);
                break;

            case "M":
                $value += ($previous === "C" ? 800 : 1000);
                break;

            default:
                throw new Exception("Invalid character");
        }

        $previous = $c;
    }

    return $value;
}