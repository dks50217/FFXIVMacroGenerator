<template>
    <div>
        <el-row :gutter="20">
            <el-select v-model="selectJob" size="small">
                <el-option v-for="item in jobOptions"
                           :key="item.value"
                           :label="item.label"
                           :value="item.value">
                </el-option>
            </el-select>
        </el-row>


        <el-row :gutter="20">
            <el-tag effect="dark">A列</el-tag>
        </el-row>

        <el-row :gutter="20" class="skillArea">
            <draggable class="list-group" v-model="skillList" group="site" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd">
                <transition-group>
                    <el-avatar v-for="(item,index) in skillList" shape="square" src="https://fuss10.elemecdn.com/e/5d/4a731a90594a4af544c0c25941171jpeg.jpeg" :key="index"></el-avatar>
                </transition-group>
            </draggable>
        </el-row>

        <el-divider></el-divider>

        <el-row :gutter="20">
            <el-tag type="success" effect="dark">B列</el-tag>
        </el-row>

        <el-row :gutter="20" class="settingArea">
            <draggable v-model="settingList" group="site" animation="300" dragClass="dragClass" ghostClass="ghostClass" chosenClass="chosenClass" @start="onStart" @end="onEnd">
                <transition-group class="list-group">
                    <el-avatar v-for="(item,index) in settingList" shape="square" src="https://fuss10.elemecdn.com/e/5d/4a731a90594a4af544c0c25941171jpeg.jpeg" :key="index"></el-avatar>
                </transition-group>
            </draggable>
        </el-row>

        <el-divider></el-divider>

        <el-row :gutter="20">
            <el-input type="textarea"
                      placeholder=""
                      v-model="macroText"
                      maxlength="30"
                      show-word-limit>
            </el-input>
        </el-row>

        <!--<el-row>
        <el-col :span="6">
            <raw-displayer :value="skillList" :title="'A'"></raw-displayer>
        </el-col>

        <el-col :span="6">
            <raw-displayer :value="settingList" :title="'B'"></raw-displayer>
        </el-col>
    </el-row>-->

    </div>
</template>

<script>
    module.exports = {
        data() {
            return {
                drag: false,
                jobOptions: [
                    { label: 'JobA' , value: 1  },
                    { label: 'JobB' , value: 2  },
                    { label: 'JobC' , value: 3  }
                ],
                skillList: [
                    { name: 'SkillA', image: '' },
                    { name: 'SkillB', image: '' },
                    { name: 'SkillC', image: '' },
                    { name: 'SkillD', image: '' },
                    { name: 'SkillA', image: '' },
                    { name: 'SkillB', image: '' },
                    { name: 'SkillC', image: '' },
                    { name: 'SkillD', image: '' },
                    { name: 'SkillA', image: '' },
                    { name: 'SkillB', image: '' },
                    { name: 'SkillC', image: '' },
                    { name: 'SkillD', image: '' },
                    { name: 'SkillA', image: '' },
                    { name: 'SkillB', image: '' },
                    { name: 'SkillC', image: '' },
                    { name: 'SkillD', image: '' },
                ],
                settingList: [
                    //{ id: 1, name: 'SkillE' },
                    //{ id: 2, name: 'SkillF' },
                    //{ id: 3, name: 'SkillG' },
                    //{ id: 4, name: 'SkillH' }
                ],
                macroText: '',
                selectJob: ''
            };
        },
        methods: {
            onStart(event) {
                this.drag = true;
            },
            onEnd() {
                this.drag = false;
            },
            setMacroText() {

            }
        },
        components: {
            'draggable': window['vuedraggable'],
            'raw-displayer': httpVueLoader('../component/raw-displayer.vue')
        },
    };
</script>

<style scoped>
    .el-avatar {
        width: 80px;
        height: 80px;
        margin: 5px;
        cursor: grab;
    }

    .skillArea, .settingArea {
        overflow: auto;
        white-space: nowrap;
    }

    .skillArea span, .settingArea span {
        display: inline-block;
    }

    .el-row {
        margin-bottom: 20px;
    }

    .list-group {
        min-height: 100px;
        min-width: 100px;
    }
</style>
