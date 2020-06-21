# S.C-V.2
 Unity Solo Project Chess base board game for MOBILE
 Rule Version 1.0.2 Edition.
 

개편 예정 - 유저 커스텀 카드덱
------------------
현재 덱 -> 

공격 3장 
행동력 +1 4장
방어 2장


개편 예정 덱 컨셉 
------------------
커스텀 다수 기본카드 X 오리지날은 존재

카드 티어

덱 구성 무조건 9장으로 구성

Normal 카드 3장까지 (중복허용)
Common 카드 3장까지 (중복허용)
Epic 카드 2장까지 (중복불가)
kingPreset 카드 1장

total : 9


프리셋 스킬
---------------
하수인 유닛에 - 특정 스킬을 장착 해서 사용하게 할 예정


Basic Rule
---------------
. 5x5 체스판 위에서 한 라운드를 공격/수비로 진행한다.

. 라운드를 종료하면 공/수 가 교대 된다.

. 공격 라운드를 진행하는 사람은 라운드 시작 시 '행동' 을 1 얻는다.

. '행동'은 공격라운드에만 얻을 수 있고 수비 라운드에서는 '행동'을 얻을 수 없다.

. 라운드가 시작되면 공격자는 '행동 턴'을 진행한다.

. '행동 턴'에는 유닛을 움직이거나 유닛으로 공격하거나, 스킬/카드를 사용할 수 있다.

. '행동 턴'을 진행하지 않고 카드를 1장 뽑고 라운드를 종료할 수 있다.

. 패에는 카드를 3장 까지만 들고 있을 수 있다.

. 스킬/카드는 '행동'을 소모하지 않는다.

. 모든 스킬은 한 라운드에 각각 한 번만 사용할 수 있다.

. '행동'을 소모하거나, 스킬/카드를 사용하면, 상대에게 '스킬 턴'이 돌아간다.

. '스킬 턴'에는 스킬/카드만 사용 할 수 있다.

. 마찬가지로 '스킬 턴'에 스킬/카드를 사용하면 상대에게 '스킬 턴'이 생긴다.

. 이때 까지 사용한 스킬/카드 행동들은 '스킬 체인'에 쌓인다.

. '스킬 턴' 에 아무것도 하지않고 턴을 넘기면 '스킬 체인'이 종료된다.

. '스킬 체인'이 종료되면 '스킬 체인'에 쌓인 모든 스킬/카드/행동을 위에서 부터 실행한다.

. 라운드 진행 중에 '킹' 유닛이 사망한 플레이어는 '체크'상태가 된다. '체크' 상태는 해제되지 않는다.

. '체크' 상태에서 처음 라운드가 시작 할 때 카드를 손패제한까지 뽑고, '킹' 유닛을 '킹' 스폰 지점에 다시 부활 시킨다.

. '체크' 상태에서 '킹'유닛을 부활 시키지 못하거나(킹 스폰지점이 막혀있다면), '킹' 유닛이 한번 더 사망하면 패배한다 (체크메이트).


Game progress system
-------------------------------
. 라운드시작

. 선공 '행동 턴' 시작 

. 행동, 스킬, 카드사용 / 카드 뽑기(라운드 종료)

. 수비 '스킬 턴' 시작

. 스킬, 카드 사용 / '스킬 턴' 패스 '스킬 체인' 정리 -> 선공 '행동 턴'으로 넘어감

. 라운드 종료 


DETAIL, COMMAND
-------------------------------
. '방향:앞'. 적진방향, '방향:뒤' 아군진영 방향, '방향:좌', '방향:우' 

. '행동', 1 소모하여 유닛 하나를 '이동' 시키거나 '일반공격'을 할 수 있다.

. '취소', 스킬 시전, '행동'에 소모된 포인트들을 돌려주고, 스킬, 행동을 무효시킨다. (스킬을 사용한 횟수는 초기화되지 않음/ 다시 시전 불가).

. '무효화', 스킬, '행동'에 소모된 포인트들을 돌려주지 않고, 스킬/카드/행동을 무효시킨다.

. '신속', 한 라운드에 1번이 아니라 2번 까지 쓸 수 있는 스킬. 

. '후속', 스킬의 추가 기능. 스킬이 진행되고 그뒤에 진행되는 추가 스킬, 조건이 맞아야만 발동하며 '후속'스킬의 조건이 만족되지 않아도 스킬은 사용할 수 있다. ex) 한칸이동한다/ 후속: 인접한 칸의 적 유닛 하나를 '기절'시킨다.

. '타격' 스킬에 명시된 지정한 방향으로 칸/범위를 제자리에서 공격한다.

. '조준' 스킬에 명시된 칸(or 여러칸)을 지정해서 제자리에서 공격한다.

. '진군' 스킬이동의 한 종류로, 지정한 방향으로 이동한다.

. '도약' 스킬이동의 한 종류로, 지정한 칸으로 이동한다. 이때, 지정한 칸에 유닛이 있으면 스킬 시전시에 제거한다.
