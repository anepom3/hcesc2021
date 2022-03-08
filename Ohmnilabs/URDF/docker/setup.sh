#!/bin/bash
docker build -t ros:melodic-ros-base  -f docker/Dockerfile .
docker run -it --rm --name xacro2urdf -p 10000:10000 -p 5005:5005 ros:melodic-ros-base /bin/bash