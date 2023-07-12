#lang racket
(require racket/contract)

(define/contract (is-palindrome x)
  (-> exact-integer? boolean?)
    (define (reverse num acc)
        (if (equal? num 0) 
          acc 
          (reverse (quotient num 10) (+ (* acc 10) (remainder num 10)))))

    (if (< x 0) #f (equal? x (reverse x 0)))
  )

(printf "example 1 -> ~a~n" (is-palindrome 121))
(printf "example 2 -> ~a~n" (is-palindrome -121))
(printf "example 3 -> ~a~n" (is-palindrome 10))
