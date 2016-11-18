## git 명령어

1. 상태 보기
    - git status

        ```bash
        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

            modified:   README.md

        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

            modified:   README.md
        ```
    - git status --short

        ```bash
            $ git status --short
            MM README.md
        ```

2. 상태 변경 내용 보기
    - staged 상태가 아닌것
        - git diff

        ```bash
            $ git diff
            diff --git a/README.md b/README.md
            index 103df66..129d053 100644
            --- a/README.md
            +++ b/README.md
            @@ -1,3 +1,13 @@
            # READ ME

            -## New Line
            +## git 명령어
            +
            +1. 상태 변경 내용 보기
            +
            +    - staged 상태가 아닌것
            +        - git diff
            +    - 커밋한 것과 staged area 있는 것 비교
            +        - git diff —staged
            +    - staged 상태인 것
            +        - git diff —cached
            +
        ```
    - 커밋한 것과 staged area 있는 것 비교
        - git diff —staged
    - staged 상태인 것
        - git diff —cached
3. git commit
    - commit
        - git commit
            - 편집기에서 comment 작성

            ```bash
            $ git commit
            [master 7e6af66] markdown!!
            1 file changed, 3 insertions(+), 1 deletion(-)
            ```
    - git commit -v
        - 편집기에 diff 메시지를 추가.
    - git commit -m "comment"
    - git commit -a -m 'commit not staged files'
        - tracked된 파일의 staged 단계를 생략한다.
        - staged 되지 않은 파일을 포함하여 commit.

        ``` bash
        $ git commit -a -m 'commit not staged files'
        [master 842dabd] commit not staged files
        1 file changed, 84 insertions(+), 1 deletion(-)
        ```
    - git commit --amend
        - commit 후 추가할 파일이 있을 때 사용한다.

4. git rm 
    - git rm 

    ```bash        
        $ git rm tempfile.md
        rm 'tempfile.md'

        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

            deleted:    tempfile.md
    ```
    - git rm --cached tempfile.md
        - staged 상태에서만 제거하고 로컬 파일은 그대로 둔다.
    - git rm log/\\*.log 
        - log/ 디렉토리에 있는 .log 파일을 모두 삭제한다.
    - git rm \\*~
        - ~로 끝나는 모든 파일을 제거한다.
5. Modified 파일 되돌리기
    - git reset HEAD tempfile.md
        - unstaged 상태로 변경

        ```bash
        $ git reset HEAD tempfile.md
        Unstaged changes after reset:
        M	README.md
        D	tempfile.md

        $ git status
        On branch master
        Changes not staged for commit:
        (use "git add/rm <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

            modified:   README.md
            deleted:    tempfile.md

        no changes added to commit (use "git add" and/or "git commit -a")
        ```
    - git checkout -- tempfile.md
        - 변경 사항 되돌리기
        - **원래 파일로 되돌리기 때문에 수정된 사항은 모두 사라진다.**

        ```bash
        $ git checkout -- tempfile.md
        ```

6. git mv
    - git mv file_from file_to
        - 파일 이름 변경한다. 

    ```bash
        $ git mv tempfile.md tempfile2.md
        
        $ git status
        On branch master
        Changes to be committed:
        (use "git reset HEAD <file>..." to unstage)

            renamed:    tempfile.md -> tempfile2.md

        Changes not staged for commit:
        (use "git add <file>..." to update what will be committed)
        (use "git checkout -- <file>..." to discard changes in working directory)

            modified:   README.md
            modified:   tempfile2.md
    ```

7. git log
    - git log 
        - 로그를 조회한다.
    - git log --pretty=oneline
    - git log --pretty=format:"%h - %an, %ar : %s"

        ```bash
            $ git log --pretty=format:"%h - %an, %ar : %s"
            79cab15 - david, 5 minutes ago : filename changed
            cf43a9a - david, 29 minutes ago : new file
            2c82830 - david, 31 minutes ago : temp file commit
            842dabd - david, 34 minutes ago : commit not staged files
            7e6af66 - david, 39 minutes ago : markdown!!
            1882b3f - david, 74 minutes ago : READ ME
        ```
    - git log --pretty=format:"%h - %an, %ar : %s" --graph
        - 브랜치와 머지 히스토리를 아스키 그래프로 출력해 준다.
    - git log --oneline --decorate
        - 현재 브랜치가 어떤 커밋을 가르키고 있는지를 보여준다.

        ```bash
        $ git log --oneline --decorate
        04345a6 (HEAD -> master, gitlab/master, markdown-test) edit
        92ea5a3 ore edit
        2a2c975 final
        f1659c4 (origin/master) changed.
        cf444ef edited again.
        2061237 markdown edited
        d5395e7 markdown edited
        a744278 modified
        5f868de Merge branch 'master' of https://github.com/thinkit-software/myRepository
        09b6cc7 chekout all
        848a151 Initial commit
        79cab15 filename changed
        cf43a9a new file
        2c82830 temp file commit
        842dabd commit not staged files
        7e6af66 markdown!!
        1882b3f READ ME
        ```

8. 리모트 저장소
    - git clone https://github.com/thinkit-software/myRepository
    - git remote
    - git remote -v

    ```bash
    $ git remote -v
    origin	https://github.com/thinkit-software/myRepository (fetch)
    origin	https://github.com/thinkit-software/myRepository (push)
    ```
    - git remote add origin https://github.com/thinkit-software/myRepository 
    - git remote add gitlab git@gitlab.com:thinkit-software/myRepository.git
        - 두번째 저장소 추가

    ```bash
    $ git remote add gitlab git@gitlab.com:thinkit-software/myRepository.git
    $ git remote -v
    gitlab	git@gitlab.com:thinkit-software/myRepository.git (fetch)
    gitlab	git@gitlab.com:thinkit-software/myRepository.git (push)
    origin	https://github.com/thinkit-software/myRepository (fetch)
    origin	https://github.com/thinkit-software/myRepository (push)
    ```
    - git fetch pb
    - git remote show origin
        - 리모트 저장소의 구체적인 정보 확인

        ```bash
        $ git remote show origin
        * remote origin
        Fetch URL: https://github.com/thinkit-software/myRepository
        Push  URL: https://github.com/thinkit-software/myRepository
        HEAD branch: master
        Remote branch:
            master tracked
        Local branch configured for 'git pull':
            master merges with remote master
        Local ref configured for 'git push':
            master pushes to master (fast-forwardable)
        ```
    - git remote rename from_name to_name
        - 리모트 저장소의 이름 변경
    - git remote rm name
        - 리모트 저장소 삭제

9. git pull
    - git pull

    ```bash
    $ git pull origin master
    From https://github.com/thinkit-software/myRepository
    * branch            master     -> FETCH_HEAD
    fatal: refusing to merge unrelated histories
    
    $ ls
    git-command.md	tempfile2.md
    
    $ git pull origin master --allow-unrelated-histories
    From https://github.com/thinkit-software/myRepository
    * branch            master     -> FETCH_HEAD
    Merge made by the 'recursive' strategy.
    README.md | 1 +
    1 file changed, 1 insertion(+)
    create mode 100644 README.md
    ```

10. branch
    - git branch new_branch
        - 신규 브랜치 생성

        ```bash
        $ git branch markdown-test

        $ git branch
        markdown-test
        * master
        ```
    - git checkout new_branch
        - HEAD는 신규 브랜치를 가리킨다.
        - 브랜치를 이동하면 워킹 디렉토리의 파일이 변경된다.
        - 이동할 때는 워킹디렉토리를 정리하는 것이 좋다. 작업하던 것을 모두 커밋하고 이동한다. 
    
        ```bash
        $ git checkout markdown-test
        M	git-command.md
        Switched to branch 'markdown-test'
        ```
    - git log --oneline --decorate --graph --all
        - 현재 브랜치가 가리키고 있는 히스토리가 무엇이고, 어떻게 갈라져 나왔는지 보여준다.

        ```bash
        $ git log --oneline --decorate --graph --all
        * f012322 (origin/markdown-test, gitlab/markdown-test, markdown-test) test5
        * 6345adf test4
        * c856ced test3
        * be58dbe test2
        * 3ab5345 branch test
        * 04345a6 (HEAD -> master, gitlab/master) edit
        * 92ea5a3 ore edit
        * 2a2c975 final
        * f1659c4 (origin/master) changed.
        * cf444ef edited again.
        * 2061237 markdown edited
        * d5395e7 markdown edited
        * a744278 modified
        *   5f868de Merge branch 'master' of https://github.com/thinkit-software/myRepository
        |\
        | * 848a151 Initial commit
        * 09b6cc7 chekout all
        * 79cab15 filename changed
        ``` 
    - git checkout -b new_branch
        - 브랜치를 생성하고 checkout까지 한다.
    - git branch -d branch_name
        - 브랜치를 삭제한다.
    - git merge
        - fast-forward : Merge 할 브랜치가 가르키는 커밋이 현 브랜치 커밋의 Upstream 브랜치이기 때문에 master 는 최신 커밋으로 이동한다.
            - A브랜치에서 B브랜치를 Merge 할 때 B가 A 이후의 커밋을 가리키고 있을 경우 A가 B의 커밋을 가리키면 된다.
    ```bash
    $ git checkout master
    Switched to branch 'master'
    Your branch is ahead of 'origin/master' by 3 commits.
    (use "git push" to publish your local commits)
    
    $ git merge markdown-test
    Updating 04345a6..f91da9a
    Fast-forward
    git-command.md | 164 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++-------------------------------
    1 file changed, 133 insertions(+), 31 deletions(-)
    ```    
    - conflict

    ```bash
    $ git merge master
    Auto-merging git-command.md
    CONFLICT (content): Merge conflict in git-command.md
    Automatic merge failed; fix conflicts and then commit the result.

    $ git status
    On branch markdown-test
    Your branch is ahead of 'origin/markdown-test' by 4 commits.
    (use "git push" to publish your local commits)
    You have unmerged paths.
    (fix conflicts and run "git commit")
    (use "git merge --abort" to abort the merge)

    Unmerged paths:
    (use "git add <file>..." to mark resolution)

        both modified:   git-command.md

    no changes added to commit (use "git add" and/or "git commit -a")
    ```
        - HEAD 버전 
            - 위쪽은 merge 명령을 실행할 때 작업하던 master 브랜치의 내용
            - 아래쪽은 markdown-test 브랜치의 버전이다.
            - 충돌을 해결하려면 위나 아래에서 고르거나 새로 작성하여 merge 한다.
        - git mergetool 
            - 다른 도구를 사용하여 충돌을 해결한다.    
        
    ```bash
    <<<<<<< HEAD
        - git branch -d branch_name
            - 브랜치를 삭제한다.

    =======
        - git merge

        ```bash
        $ git checkout master
        Switched to branch 'master'
        Your branch is ahead of 'origin/master' by 3 commits.
        (use "git push" to publish your local commits)

        $ git merge markdown-test
        Updating 04345a6..f91da9a
        Fast-forward
        git-command.md | 164 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++-------------------------------
        1 file changed, 133 insertions(+), 31 deletions(-)
        ```
    >>>>>>> master
    ```