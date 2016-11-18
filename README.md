# READ ME

## git 명령어
---

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