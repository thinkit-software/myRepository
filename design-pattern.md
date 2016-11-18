# 디자인 패턴

## SOLID

1. S

1. The Open-Closed Principle
    1. Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
    1. When a single change to a program results in **a cascade of changes to dependent modules**, the design smells of **Rigidity**.
        - 프로그램의 어느 한 부분을 변경하였는데, 그로 인하여 종속적인 모듈들에 폭포가 쏟아져 내리는 것과 같은 많은 변경 사항이 발생한다면, 그 디자인은 Rigidity의 낌새가 나는 것이다.
    1. OCP는 그러한 변경이 더 발생하였을 때 더 많은 변경 사항을 발생시키지 않도록 하기 위한 리팩토링 방법에 대한 조언을 준다. 만약 OCP가 잘 적용된다면, 그러한 변경의 발생은 존재하던 *코드를 변경하는 것이 아닌, 새로운 코드를 추가하는 것*으로 그러한 변경 사항을 달성할 수 있다.
        - 일반적으로 모듈의 행동을 확장하려면 그 모듈의 소스코드를 수정해야 하고, 소스를 수정할 수 없다면 그 모듈의 행동은 고정된 것이라 생각할 수 있다. 
        - 그러면 소스코드의 수정없이 어떻게 모듈의 행동을 바꾸는 것이 가능할까?
    1. 추상화
        - 고정된 추상 클래스
            - 모듈은 고정된 추상 클래스에 의존하기 때문에 수정에 대해서 닫혀 있다.
        - 가능한 행동들을 나타낼 수 있는 추상 클래스를 상속한 클래스들
            - 새로운 추상 클래스를 만듦으로써 모듈의 추가 행동들을 확장할 수 있다.

            ![Client not open and closed](./images/design_pattern_ocp_001.png)

1. L

1. I

1. D
