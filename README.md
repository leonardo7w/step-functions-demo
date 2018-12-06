# step-functions-demo

Package 
./build.ps1 -Target=Package

Cloudformation Package
aws cloudformation package --template-file template.yaml --output-template-file packaged.yaml --s3-bucket step-functions-demo

Cloudformation Deploy
aws cloudformation deploy --template-file packaged.yaml --stack-name stepFunctionDemo --capabilities CAPABILITY_IAM 
