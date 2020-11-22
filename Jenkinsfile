pipeline{
    agent any


    triggers{
        pollSCM 'H/20 * * * *'
    }
    stages{
        stage("git checkout"){
            steps{
                git credentialsId: 'github', url: 'https://github.com/FatihMert1/Jenkins-Meeting.git'
                
            }
            post{
                always{
                    echo "========always========"
                }
                success{
                    echo "========build executed successfully========"
                }
                failure{
                    echo "========build execution failed========"
                }
            }
        }
    }

}