using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action {
    public ActionTypes ActionType { get; set; }

    public Action () {

    }

    public void ApplyDamageTo (Unit from, Unit to) {

    }

    public void ApplyBuffTo (Unit from, Unit to) {

    }

    public void ApplySelfBuff () {

    }

    public ActionTypes GetActionType { get { return ActionType; } }

    public void ApplyShieldTo (Unit from, Unit to) {

    }
}