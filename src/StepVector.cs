class StepVector : Position {
    public StepVector(int vectX, int vectY) {
        _x = vectX;
        if (vectX > 1) {
            _x = 1;
        }
        else if (vectX < -1) {
            _x = -1;
        }
        _y = vectY;
        if (vectY > 1) {
            _y = 1;
        }
        else if (vectY < -1) {
            _y = -1;
        }
    }
}