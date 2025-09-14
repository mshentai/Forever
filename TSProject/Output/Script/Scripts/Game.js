var Game;
(function (Game) {
    function init() {
        CS.UnityEngine.Debug.LogError("init");
    }
    Game.init = init;
    function dispose() {
        CS.UnityEngine.Debug.LogError("dispose");
    }
    Game.dispose = dispose;
})(Game || (Game = {}));
export default Game;
