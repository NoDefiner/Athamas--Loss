<color=orange>누구세요?</color>
안녕하세요. 옆집 237호입니다. 실례지만 몇가지 여쭤봐도 됩니까?
<color=orange>저번에도 오지 않았나요?</color>
예? 죄송하지만 이웃주민 분들과는 이사한 이후로 처음 뵙는겁니다...
... 질문이 뭐죠
. 
->choice
===choice===
+[아들에 대해서] -> first
+[우리 집에 대해서] -> second
+[238호에 대해서] -> third

=== first===
혹시 이전에 제 아들을 본적 있으신가요? 머리색은 저와 닮은 갈색이고 나이는 20살 정도였습니다.
<color=orange>글쎄요. 본적이 없습니다.</color>
....
.
+[질문을 한다]->choice
+[질문을 하지 않는다] -> END

===second ===
혹시 저희 집에서 나는 소리를 들으신적 있나요? 마치 사람이 내는 소리가 아닌거 같은 그런 큰 소리요.
<color=orange>제정신이야? 별 이상한 걸 다 물어보네</color>
(역시 괴물의 존재를 물어보긴 힘들거같다.)
.
+[질문을 한다]->choice
+[질문을 하지 않는다] -> END

=== third ===
238호에는 사람이 없나요? 아까 문을 두드렸는데 아무도 안계시는거 같던데. 
<color=orange>당신 경찰이야?</color>
예?
<color=orange>경찰이냐고. 뭘 그렇게 꼬치꼬치 묻고 다니는거야</color>
경찰은 아니고, 제 아들과 관련되서 여기저기서 알아보고 다니는 중입니다.
<color=orange>이런거 민간인이 함부로 할 수 있는 영역도 아닐뿐더러 잘못하다간 경찰 사칭으로 잡혀간다고 작작 좀 해.</color>
(이 사람에게 정보를 얻을 수 없을 거 같다)
.
+[질문을 한다]->choice
+[질문을 하지 않는다] -> END


