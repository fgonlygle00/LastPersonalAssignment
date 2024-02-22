# Last Personal Assignment
Unity 3D 마지막 개인 과제

## 🖥️프로젝트 소개
Untity 3D 숙련 강의 내용을 그대로 인트로만 작업하여 진행한 개인 과제

오랜 만에 찾아온 쉬운 난이도의 과제 덕분에 다 완료 하지 못한 기존 강의 들을 다시

보면서 이번 개인 과제 주차 동안 강의를 완강하는데 목표로 두었습니다.

## 🗓️개발 기간
* 2024.02.19 ~ 2024.02.22

## 👨‍👩‍👧‍👦멤버 구성
* 개인 과제

## 🪟개발 환경
* Unity Editor 2022.3.2f1

* Visual Studio 2022

* Window 11

## ✨주요 기능
* 필수 기능 - 인트로 씬 구현

## 📄CS 구성
#### StartScene
< UIManager > 게임 시작 화면에 있는 UI 설정

#### SampleScene
<details>
<summary>Eviroments</summary>
 
< CampFire.cs > 맵에 배치 되어있는 불에 닿으면 데미지
 
< DayNightCycle.cs > 현재 게임의 낮과 밤을 구현

< Resource.cs > 맵에 배치 되어있는 자원(나무, 돌 등등)을 캐면 해당 자원 획득 및 일정 획득 시 해당 자원 파괴
</details>

<details>
<summary>Items</summary>
 
< InteractionManager.cs > 상호작용이 가능한 오브젝트에 특정 기준(현재 크로스 해어 기준)에 닿으면 상호작용 텍스트 띄우기
 
< ItemObject.cs > InteractionManager.cs와 연관되어 기준에 닿은 오브젝트가 어떤 오브젝트인지 알려줘서 텍스트 띄우기
</details>

<details>
<summary>NPC</summary>
 
< NPC.cs > 맵에 배치 되어있는 NPC(현재 곰)의 이동가능 경로, 플레이어가 NPC 범위 내에있는지 감지, 플레이어게 이동, 공격 그리고 범위를 벗어나면 다시 가능한 동작 하기 
</details>

<details>
<summary>Player</summary>
 
< Equip.cs > EquipTool의 부모
 
< EquipManager.cs > 장착 가능 장비를 장착 및 해제 하고 공격하

< EquipTool.cs > Equip을 부모로 받아와서 공격 모션 및 공격 가능 범위 설정

< Inventroy.cs > 상호작용이 가능한 오브젝트를 획득하면 인벤토리 창에 정렬 밑 상태 표시

< PlayerConditions.cs > 플레이어의 현재 컨디션 표시 (체력, 허기, 스테미나)

< PlayerController.cs > 플레이어의 기본적인 동작( 무빙, 카메라 무빙, 점프)
</details>

<details>
<summary>UI</summary>
 
< DamageIndicator.cs > 데미지를 받으면 화면에 데미지 받는 효과 추가
 
< ItemSlotUI.cs > 인벤토리에 있는 항목 기본 배치 설정
</details>

<details>
< Footsteps.cs > 캐릭터 발소리 설정
 
< MusicZone.cs > 특정 구역에 오면 배경음악 재생
</details>

## 그외 기타 내용은 팀 노션에서
### <https://teamsparta.notion.site/1-30mg-c3ccb33f3aae4ba0a3f92610a8880b48?pvs=25>
