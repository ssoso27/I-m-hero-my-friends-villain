# I-m-hero-my-friends-villain

####GitBash 사용 관련
git clone, init, status, add, pull, push, commit 등의 명령어는 기본적으로 개인 저장소에서 사용했으니 설명을 생략합니다.
>**git remote add upstream https://github.com/JNU-Room/avoid.git<br>
-upstream 저장소를 해당 url로 지정합니다.(최초 한번만 실행하도록 합시다.)<br>
-항상 저장소를 최신으로 유지하기 위함입니다.**<br>

**commit 전에 항상 해야 할 명령어**
>**git fetch upstream<br>
git merge upstream/master**

이후 status , add, commit 및 push하면 끝. (번거롭지만 타인의 프로젝트에 기여할 때엔 필수사항임에 따라, 연습겸 해보는 것으로 합시다.)<br>

---
### 간단 Git Bash 사용법
#### 1. 지정 폴더 들어가기
-- ls :: 현재 디렉터리의 파일 및 하위 디렉터리를 보여준다<br>
-- cd <하위 디렉터리명> :: 하위 디렉터리로 이동한다<br>
-- cd .. :: 상위 디렉터리로 이동한다<br>

&nbsp;&nbsp;&nbsp;**1-1. git clone**<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- github에 올라와 있는 파일을 (현재 디렉터리에) 다운 받는 명령어<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 최초 한 번만 하면 된다.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--**사용법 :: git clone https://github.com/ssoso27/Mc_MiniGames.git**<br>
&nbsp;&nbsp;&nbsp;**1-2. git pull**<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 현재 디렉터리의 프로젝트를 github에 올라온 최신 버전으로 업데이트 하는 명령어<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-- 항상 최신 버전을 유지하기 위해, 다른 팀원이 git push를 했다면 git pull를 해야한다.<br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--**사용법 :: git pull**<br>

#### 2. git add
-- 파일을 준비 영역에 추가하는 명령어<br>
-- **사용법 :: git add <파일 또는 폴더명>**<br>
-- ex) git add YSH/ <br>
-- ex) git add test.cpp <br>
####3. git commit
-- (git add로 추가된) 준비 영역의 파일을 최종 확정하는 명령어<br>
-- **사용법 :: git commit -m "파일에 대한 설명 문구"**<br>
-- ex) git commit -m "커밋 테스트" <br>
####4. git push
-- (git commit으로 확정된) 파일을 원격 서버에 올리는 명령어<br>
-- 아마 처음엔 로그인 하라고 에러 메시지가 나올텐데, 침착하게 자기 아이디랑 비번을 입력하면 된다.<br>
-- **사용법 :: git push**<br>
####5. git status
-- 현재 폴더의 상태 확인<br>
-- 수정된 파일 등을 나타냄 <br>
-- **사용법 :: git status** <br>
####6. 자신의 업로드 이후
#####-- ( add -> commit -> push 이후 할 일)
-- 자신의 업로드 내역을 적용시키기 위해 요청해야함 <br>
-- 자신의 Repository (웹 사이트) -> [Pull requests] -> [New pull request] -> [Create pull request]<br>
####7. 누군가의 업로드 이후
#####-- ( = 자신이 commit 하기 전 항상 해야 할 명령어)

--  <font size = 4.5> <b>git fetch upstream</b> <br>
-- <b>git merge upstream/master</b><br>
-- <b>git push</b></font>

####* 석 줄 요약
-- 한 번도 clone을 안 했을 경우, clone을 한다.<br>
-- **add -> commit -> push** 순으로 파일 업로드<br>
-- 다른 팀원들이 새로 업로드 했을 경우, **fetch -> merge -> push**를 한다.<br>


**remote 설정과 관련해서 에러가 있을 경우, 즉, origin 주소가 개인 fork저장소가 아닌, ssoso27-avoid 저장소로 지정되어 권한 없음으로 push가 안될 경우 해결법**

>**1)git bash 실행 후, cd avoid 입력<br>
2)git remote -v 입력 후, origin 주소 확인시,<br> https://github.com/ssoso27/I-m-hero-my-friends-villain.git 로 보인다면 수정 필요<br>
3)git remote set-url origin https:본인 fork 저장소 입력<br>
4)다시 git remote -v 입력 후 잘 변경되었는지 확인.**<br>
<br>

위 방법을 사용할 경우에 간단하게 해결될 문제임에 따라, 다시 clone하는 수고를 겪지 않았으면 좋겠습니다.<br>

**알아두면 나름 편리한(?) Git 명령어**<br>
>**1)explorer . - git bash에서 지정한 위치의 탐색기 창을 open**<br>

git관련해서 이슈사항이 있으면 다시 정리해서 올려드리겠습니다.<br>

