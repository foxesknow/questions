#lang racket
(require racket/contract)

(define/contract (roman-to-int s)
  (-> string? exact-integer?)
    (define (offset last c)
        (cond
           [(equal? c #\I) 1]
           [(and (equal? c #\V) (equal? last #\I)) 3]
           [(equal? c #\V) 5]
           [(and (equal? c #\X) (equal? last #\I)) 8 ]
           [(equal? c #\X) 10]
           [(and (equal? c #\L) (equal? last #\X)) 30]
           [(equal? c #\L) 50]
           [(and (equal? c #\C) (equal? last #\X)) 80]
           [(equal? c #\C) 100]
           [(and (equal? c #\D) (equal? last #\C)) 300]
           [(equal? c #\D)500]
           [(and (equal? c #\M) (equal? last #\C)) 800]
           [(equal? c #\M) 1000]
           [else 0]))
    
    (define (execute last rest acc)
        (cond
         [(empty? rest) acc]
         [else 
          (let ([c (car rest)] [next (cdr rest)])
            (execute c next (+ acc (offset last c))))]))

    (execute #\space (string->list s) 0)
  )