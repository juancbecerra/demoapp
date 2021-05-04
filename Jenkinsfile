#!groovy​
pipeline {
	agent { node { label 'WindowsNode'}}

	options {
        buildDiscarder(logRotator(numToKeepStr: '10'))
     }

	environment {
        SOLUTION_NAME = 'DemoApp.sln'        
        CONFIGURATION = 'Release'
    }

	 stages {
		stage('Build)
		{
			steps {
				bat'''
                    "c:\\program files\\dotnet\\dotnet.exe" build "%WORKSPACE%\\%SOLUTION_NAME%" --configuration %CONFIGURATION%
                '''
			}
		}
	 }
}