pipeline {
    agent { node any }

    options {
        buildDiscarder(logRotator(numToKeepStr: '10'))
    }

    environment {
        SOLUTION_NAME = 'DemoApp.sln'
        CONFIGURATION = 'Release'
    }

     stages {
		 stage('Checkout')
		 {
			checkout([$class: 'GitSCM', branches: [[name: '*/dev']],
    userRemoteConfigs: [[url: 'https://github.com/juancbecerra/demoapp.git']]])
		 }
        stage('Build')
        {
            steps {
                bat'''
                    "c:\\program files\\dotnet\\dotnet.exe" build "%WORKSPACE%\\%SOLUTION_NAME%" --configuration %CONFIGURATION%
                '''
            }
        }
     }
}