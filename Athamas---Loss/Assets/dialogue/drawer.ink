
->main
VAR firstnum = 1
=== main ===
두 개의 칸으로 나뉜 서랍이다. 

+[첫 번째 칸] -> first
+[두 번째 칸] -> second

=== first ===
수첩을 얻었다.
->main
    
=== second ===
열쇠를 얻었다.
{ firstnum >0 : 
    ->another
    -else:
    ->main
    }
    



->another
=== another ===
두 개의 칸으로 나뉜 서랍이다. 

+[첫 번째 칸] -> firstt
+[두 번째 칸] -> secondd

=== firstt===
텅 비어있다.
->another

=== secondd===
텅 비어있다.
->another


