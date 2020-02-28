using System;

namespace Gun_Master_9000{

    class Gun {
        string name;
        int capacity;
        int rounds = 0;
        public Gun(string name, int capacity) {
            this.name = name;
            this.capacity = capacity;
        }
        public void Shoot(Target target){
            if(target == null){
                throw new System.ArgumentException("Target can´t be null", "target");
            }
            if(rounds > 0){
                target.Shot();
                rounds--;
            }else{
                throw new System.InvalidOperationException("trying to shooot a gun without");
            }
        }
        public void Reload(){
            this.rounds = this.capacity;
            
        }
        public int GetRemainingRouds(){
            return this.rounds;
        }
    }
}