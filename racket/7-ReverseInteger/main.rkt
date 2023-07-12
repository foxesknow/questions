#lang racket
(require racket/contract)

(define max-int 2147483647)

(define/contract (reverse x)
  (-> exact-integer? exact-integer?)
    (define (reverse num acc)
        (define next-digit (remainder num 10))
        (cond
          [(equal? num 0) acc]
          [(and (> acc 0) (< (/ (- max-int next-digit) acc) 10)) 0]
          [else (reverse (quotient num 10) (+ (* acc 10) next-digit))]
        ))
        

    (if (< x 0) (* -1 (reverse (abs x) 0)) (reverse x 0))
 )

(printf "example 1 -> ~a~n" (reverse 123))
(printf "example 2 -> ~a~n" (reverse -123))
(printf "example 3 -> ~a~n" (reverse 120))
(printf "example 4 -> ~a~n" (reverse 1534236469))
