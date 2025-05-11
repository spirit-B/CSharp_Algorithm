// 전체 입력 받아서 리스트에 저장
List<string> input = new List<string>();
string line;

while ((line = Console.ReadLine()) != null && line != "")
{
    input.Add(line);
}

int index = 0;
int testCaseCount = int.Parse(input[index++]);  // 테스트 케이스의 수

for (int test = 0; test < testCaseCount; test++)
{
    string[] parts = input[index++].Split(" ");
    int N = int.Parse(parts[0]);    // 국가의 수
    int M = int.Parse(parts[1]);    // 비행기의 수

    for (int i = 0; i < M; i++)
    {
        index++;
    }

    Console.WriteLine(N - 1);
}