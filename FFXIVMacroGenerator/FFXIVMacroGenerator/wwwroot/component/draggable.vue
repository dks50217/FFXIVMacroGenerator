<template>
    <div>
        <el-row :gutter="20">
            <div class="title">A列</div>
            <draggable v-model="skillList" group="site" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd">
                <el-avatar v-for="(item,index) in skillList" shape="square" src="https://fuss10.elemecdn.com/e/5d/4a731a90594a4af544c0c25941171jpeg.jpeg"></el-avatar>
            </draggable>
        </el-row>


        <el-row :gutter="20">
            <div class="title">B列</div>
            <draggable v-model="settingList" group="site" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd">
                <transition-group>
                    <el-card shadow="always" v-for="(item,index) in settingList" :key="index">
                        {{item.name}}
                    </el-card>
                </transition-group>
            </draggable>
        </el-row>

        <el-row>
            <el-col :span="6">
                <raw-displayer :value="skillList" :title="'A'"></raw-displayer>
            </el-col>

            <el-col :span="6">
                <raw-displayer :value="settingList" :title="'B'"></raw-displayer>
            </el-col>
        </el-row>
    </div>
</template>

<script>
    module.exports = {
        data() {
            return {
                drag: false,
                skillList: [
                    { name: 'SampleA', image: '' },
                    { name: 'SampleB', image: '' },
                    { name: 'SampleC', image: '' },
                    { name: 'SampleD', image: '' }
                ],
                settingList: [
                    { id: 1, name: 'SampleE' },
                    { id: 2, name: 'SampleF' },
                    { id: 3, name: 'SampleG' },
                    { id: 4, name: 'SampleH' }
                ]
            };
        },
        methods: {
            onStart() {
                this.drag = true;
            },
            onEnd() {
                this.drag = false;
            },
        },
        components: {
            'draggable': window['vuedraggable'],
            'raw-displayer': httpVueLoader('../component/raw-displayer.vue')
        },
    };
</script>

<style scoped>
</style>
