using UnityEngine;
using dove;

namespace game 
{
[GameSystem(-100)]
public class GameCore : IGameSystem
{
    public GameMain Game { get; set; }

    public void OnInit() {
    }
    public void OnRelease() {
    }
}
}