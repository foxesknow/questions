#lang racket/base
(require racket/contract)
; Definition for singly-linked list:

; val : integer?
; next : (or/c list-node? #f)
(struct list-node (val next) #:mutable #:transparent)

; constructor
(define (make-list-node [val 0] [next #f])
  (list-node val next))

(define/contract (merge-two-lists list1 list2)
  (-> (or/c list-node? #f) (or/c list-node? #f) (or/c list-node? #f))
  (cond
    [(boolean? list1) list2]
    [(boolean? list2) list1]
    [(< (list-node-val list1) (list-node-val list2))
     (set-list-node-next! list1 (merge-two-lists (list-node-next list1) list2))
     list1]
    [else
     (set-list-node-next! list2 (merge-two-lists list1 (list-node-next list2)))
     list2]))

(define test-1
  (lambda ()
    (define a (make-list-node 1 (make-list-node 3)))
    (define b (make-list-node 2))
    (merge-two-lists a b)))

(define test-2
  (lambda ()
    (define a (make-list-node 1 (make-list-node 3 (make-list-node 5))))
    (define b (make-list-node 2 (make-list-node 4 (make-list-node 6))))
    (merge-two-lists a b)))
