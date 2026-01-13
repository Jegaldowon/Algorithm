using System;
using System.Collections.Generic;

public class Solution
{
    int[] dx = { -1, 1, 0, 0 };
    int[] dy = { 0, 0, -1, 1 };

    public int solution(int[,] maps)
    {
        int n = maps.GetLength(0);
        int m = maps.GetLength(1);

        // 시작 또는 도착이 벽이면 실패
        if (maps[0, 0] == 0 || maps[n - 1, m - 1] == 0)
            return -1;

        Queue<(int x, int y)> q = new Queue<(int, int)>();
        int[,] dist = new int[n, m];

        // 방문 배열 초기화
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                dist[i, j] = -1;

        q.Enqueue((0, 0));
        dist[0, 0] = 1; // 시작 칸 포함 거리

        while (q.Count > 0)
        {
            (int x, int y) cur = q.Dequeue();

            for (int dir = 0; dir < 4; dir++)
            {
                int nx = cur.x + dx[dir];
                int ny = cur.y + dy[dir];

                if (nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
                if (dist[nx, ny] != -1) continue;
                if (maps[nx, ny] == 0) continue;

                dist[nx, ny] = dist[cur.x, cur.y] + 1;
                q.Enqueue((nx, ny));
            }
        }

        return dist[n - 1, m - 1];
    }
}
