FROM ohmnilabsvn/ohmni_ros:ohmni_ros_tbcontrol_0.0.8.1

RUN sudo apt-get update && sudo apt-get install -y vim iputils-ping net-tools python-pip dos2unix

ENV ROS_WORKSPACE=/catkin_ws

# Copy over ROS-TCP-Endpoint to connect with Unity
RUN git clone https://github.com/Unity-Technologies/ROS-TCP-Endpoint.git $ROS_WORKSPACE/src/ROS-TCP-Endpoint

COPY ./set-up-workspace /setup.sh

RUN /bin/bash -c "find $ROS_WORKSPACE -type f -print0 | xargs -0 dos2unix"

RUN dos2unix /setup.sh && chmod +x /setup.sh && /setup.sh && rm /setup.sh

WORKDIR $ROS_WORKSPACE

# Source the workspace on sign in
RUN echo ". devel/setup.bash" >> ~/.bashrc

