#lang racket
(require racket/contract)

(define open-paren #\( )
(define close-paren #\) )
(define open-square #\[ )
(define close-square #\] )
(define open-brace #\{ )
(define close-brace #\} )

(define/contract (is-valid s)
  (-> string? boolean?)
    
    (define (execute stream stack)
      (define c (read-char stream))  
      (cond
        ; We've processed every character
        [(equal? c eof) (equal? stack null)]

        ; It's the start of a scope
        [(or (equal? c open-paren) (equal? c open-square) (equal? c open-brace)) (execute stream (cons c stack))]

        ; If there's nothing in the stack then we can't pop it in the else
        [(equal? stack null) #f] 

        ; It's one of the close characters, we need to match it with the top of the stack
        [else
          (let ([top (car stack)] [next-stack (cdr stack)])
           (cond
            [(and (equal? top open-paren) (equal? c close-paren)) (execute stream next-stack)]
            [(and (equal? top open-square) (equal? c close-square)) (execute stream next-stack)]
            [(and (equal? top open-brace) (equal? c close-brace)) (execute stream next-stack)]
            [else #f]))
        ]
      )
    )

    (execute (open-input-string s) null)
)

(printf "example 1 -> ~a~n" (is-valid "()"))
(printf "example 2 -> ~a~n" (is-valid "()[]{}"))
(printf "example 3 -> ~a~n" (is-valid "(]"))
