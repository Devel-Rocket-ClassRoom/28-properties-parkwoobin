using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Player1 player1 = new Player1();   // 1. public 필드의 문제점
player1.Health = 100;
player1.Health = -999;
Console.WriteLine($"플레이어의 체력: {player1.Health}");

Player2 player2 = new Player2();   // 2. Get/Set 메서드 방식
player2.SetHealth(100);
Console.WriteLine($"{player2.GetHealth()}");

Person1 person1 = new Person1();   // 3. 전체 프로퍼티
person1.Name = "홍길동";
Console.WriteLine($"{person1.Name}");

Developer1 dev1 = new Developer1();   // 4. 자동 구현 프로퍼티
dev1.Name = "김개발";
dev1.Age = 25;
Console.WriteLine($"{dev1.Name},  {dev1.Age}세");

Player3 player3 = new Player3();   // 5. 자동 프로퍼티 이니셜라이저
Console.WriteLine($"이름: {player3.Name}\n레벨: {player3.Level}\n최대 체력: {player3.MaxHealth}");

Car car = new Car();   // 6. 전체 프로퍼티 vs 자동 프로퍼티
car.Name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.Name}, {car.Color}");

Product product = new Product();   // 7. 읽기 전용 프로퍼티
Console.WriteLine($"{product.Manufacturer}");

Page page = new Page();   // 8. private set 프로퍼티
Console.WriteLine($"{page.Message}");
page.UpdateMessage("업데이트된 메시지");
Console.WriteLine($"{page.Message}");

SecureData secureData = new SecureData();   // 9. 쓰기 전용 프로퍼티
secureData.Password = "secret123";
Console.WriteLine($"{secureData.Validate("secret123")}");

Circle circle = new Circle() { Radius = 5 };    // 10. 읽기 전용 식 본문 프로퍼티
Console.WriteLine($"반지름: {circle.Radius}");
Console.WriteLine($"넓이: {circle.Area}");
Console.WriteLine($"둘레: {circle.Circumference}");

Counter counter = new Counter();    // 11. get/set 식 본문
counter.Count = 10;
counter.Increase();
Console.WriteLine($"카운트: {counter.Count}");

Player player = new Player();   // 12. 프로퍼티로 유효성 검사
player.Health = 150;
Console.WriteLine($"체력: {player.Health}");
player.Health = -50;
Console.WriteLine($"체력: {player.Health}");

Person2 person2 = new Person2() { Name = "홍길동" };    // 13. 계산된 프로퍼티
person2.BirthYear = 2000;
Console.WriteLine($"{person2.Name}의 나이: {person2.Age}세");

Course course = new Course();   // 14. 개체 이니셜라이저 (기존 방식)
course.Id = 1;
course.Title = "C# 기초";
Console.WriteLine($"{course.Id} - {course.Title}");



Course2 course1 = new Course2() { Id = 2, Title = "Unity 게임 개발" };   // 15. 개체 이니셜라이저 사용
Course2 course2 = new Course2() { Id = 1, Title = "C# 기초" };   // 15. 개체 이니셜라이저 사용
Course2 course3 = new Course2() { Id = 1, Title = "C# 중급" };   // 15. 개체 이니셜라이저 사용
Course2 course4 = new Course2() { Id = 3, Title = "Unity 입문" };   // 15. 개체 이니셜라이저 사용

foreach (var i in new[] { course1, course2, course3, course4 })
{
    Console.WriteLine($"{i.Id} - {i.Title}");
}

Customer customer = new Customer()  // 16. 데이터 클래스
{ Id = 1, Name = "김철수", Email = "kim@example.com", City = "서울" };
Console.WriteLine($"고객 #{customer.Id}\n이름: {customer.Name}\n이메일: {customer.Email}\n도시: {customer.City}");

Console.WriteLine($"게임: {GameSettings.GameTitle}");   // 17. 정적 프로퍼티
Console.WriteLine($"최대 플레이어 수: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IsSoundEnabled}");
GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 플레이어 수: {GameSettings.MaxPlayers}");

Monster monster = new Monster("고블린");   // 18. 프로퍼티 종합 예제
monster.Level = 5;
monster.Attack = 15;

Console.WriteLine($"이름: {monster.Name}");
Console.WriteLine($"레벨: {monster.Level}");
Console.WriteLine($"체력: {monster.Health}");
Console.WriteLine($"공격력: {monster.Attack}");
Console.WriteLine($"방어력: {monster.Defense}");
Console.WriteLine($"생존: {monster.IsAlive}");
monster.TakeDamage(50);
Console.WriteLine($"50 대미지 후 체력: {monster.Health}");



class Player1    //  1. public 필드의 문제점
{
    public int Health;
}

class Player2   // 2. Get/Set 메서드 방식
{
    private int _health;

    public void SetHealth(int health)
    {
        if (health >= 0 && health <= 100)
        {
            _health = health;
        }
    }
    public int GetHealth()
    {
        return _health;
    }
}

class Person1   // 3. 전체 프로퍼티
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
}

class Developer1    // 4. 자동 구현 프로퍼티
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Player3   // 5. 자동 프로퍼티 이니셜라이저
{
    public string Name { get; set; } = "플레이어";
    public int Level { get; set; } = 1;
    public int MaxHealth { get; set; } = 100;
}

class Car   // 6. 전체 프로퍼티 vs 자동 프로퍼티
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Color { get; set; }
}

class Product   // 7. 읽기 전용 프로퍼티
{
    public string Manufacturer
    {
        get { return "한국전자"; }
    }
}

class Page  // 8. private set 프로퍼티
{
    public string Message { get; private set; } = "읽기 전용 메시지";

    public void UpdateMessage(string message)
    {
        Message = message;
    }
}

class SecureData    // 9. 쓰기 전용 프로퍼티
{
    private string _password;

    public string Password
    {
        set { _password = value; }
    }
    public bool Validate(string input)
    {
        return _password == input;
    }
}

class Circle    // 10. 읽기 전용 식 본문 프로퍼티
{
    public int Radius { get; set; }
    public double Area => 3.14159 * Radius * Radius;
    public double Circumference => 2 * 3.14159 * Radius;
}

class Counter   // 11. get/set 식 본문
{
    private int _count;
    public int Count
    {
        get => _count;
        set => _count = value;
    }

    public void Increase() => _count++;
}

class Player    // 12. 프로퍼티에서 유효성 검사
{
    private int _health;
    public int Health
    {
        get { return _health; }
        set
        {
            if (value > 100)
            {
                _health = 100;
            }
            else if (value < 0)
            {
                _health = 0;
            }
            else
            {
                _health = value;
            }
        }
    }
}

class Person2   // 13. 계산된 프로퍼티
{
    private int _birthYear;
    public string Name { get; set; }

    public int BirthYear
    {
        set
        {
            if (value >= 1900)
            {
                _birthYear = value;
            }
        }
    }

    public int Age
    {
        get { return DateTime.Now.Year - _birthYear; }
    }
}

class Course    // 14. 개체 이니셜라이저 (기존 방식)
{
    public int Id { get; set; }
    public string Title { get; set; }
}

class Course2   // 15. 개체 이니셜라이저 사용
{
    public int Id { get; set; }
    public string Title { get; set; }
}

class Customer  // 16. 데이터 클래스
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}

class GameSettings      // 17. 정적 프로퍼티
{
    public static string GameTitle { get; set; } = "My Game";
    public static int MaxPlayers { get; set; } = 4;
    public static bool IsSoundEnabled { get; set; } = true;
}

class Monster   // 18. 프로퍼티 종합 예제
{
    private int _health;

    private const int K_MaxHealth = 100;
    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > K_MaxHealth)
            {
                _health = K_MaxHealth;
            }
            else
            {
                _health = value;
            }
        }
    }
    public string Name { get; private set; }
    public int Level { get; set; } = 1;
    public int Attack { get; set; } = 10;

    public bool IsAlive => Health > 0;
    public int Defense => Level * 2;

    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        int actualDamage = damage - Defense;
        if (actualDamage > 0)
        {
            Health -= actualDamage;
        }
    }
}